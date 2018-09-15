﻿using ValidationService.Results;

namespace ValidationService
{
    /// <summary>
    /// Base class for services of object validation
    /// <para><see cref="Validate{T}(T, string)"/> should be overridden to implement validation logic.</para>
    /// </summary>
    public abstract class ValidationService
    {
        /// <summary>
        /// Gets or sets a flag indicating whether the validation should be accomplished recursively.
        /// </summary>
        public bool IsRecursiveValidation { get; protected set; }

        /// <summary>
        /// Gets the object indicating whether or not the specified <paramref name="obj"/> is valid
        /// </summary>
        /// <typeparam name="T">The type of object to be validated</typeparam>
        /// <param name="obj">The object to validate</param>
        /// <param name="objName">The object name. 
        /// Used to print full qualified property names to <see cref="GeneralConclusion.Details"/></param>
        /// <returns>
        /// <see cref="GeneralConclusion"/> with <c>IsValid</c> flag set to <c>true</c> 
        /// if the <paramref name="obj"/> is acceptable. Otherwise, the flag is set to <c>false</c> and
        /// <see cref="GeneralConclusion.Details"/> contains a report on problems.
        /// </returns>
        public abstract GeneralConclusion Validate<T>(T obj, string objName = "") where T : class;
    }
}
    