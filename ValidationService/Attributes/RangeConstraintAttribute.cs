﻿using System;
using ValidationService.Results;

namespace ValidationService.Attributes {
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class RangeConstraintAttribute : ValidationAttribute {
        public IComparable Min { get; set; }
        public IComparable Max { get; set; }
        public string FailureMessage { get; set; } = "Property value must satisfy specified constraints";

        public RangeConstraintAttribute(IComparable min, IComparable max = null) {
            this.Min = min;
            this.Max = max;
        }

        public override ElementaryConclusion Validate(object obj) {
            if (this.Min == null && this.Max == null) {
                throw new ArgumentNullException("Constraints are not specified");
            }

            try {
                if ((this.Min != null && this.Min.CompareTo(obj) > 0) || 
                    (this.Max != null && this.Max.CompareTo(obj) < 0)) 
                {
                    return new ElementaryConclusion(isValid: false, this.FailureMessage);
                }
            } catch {
                throw new ArgumentException("Range constraints and validated object are not compatible");
            }

            return new ElementaryConclusion(isValid: true);
        }
    }
}
