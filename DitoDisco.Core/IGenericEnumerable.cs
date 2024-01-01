using System;
using System.Collections.Generic;


namespace DitoDisco.Core {

    /// <summary>
    /// <see cref="System.Collections.Generic.IEnumerable{T}"/>, but with a default implementation for <see cref="System.Collections.IEnumerable.GetEnumerator"/> that calls <see cref="System.Collections.Generic.IEnumerable{T}.GetEnumerator"/>.
    /// </summary>
    public interface IGenericEnumerable<T> : IEnumerable<T> { // (the best thing since canned bread)

        /// <summary>
        /// Intentionally hides and serves the same purpose as <see cref="IEnumerable{T}.GetEnumerator"/>.
        /// </summary>
        public new IEnumerator<T> GetEnumerator();


        /// <summary>
        /// Calls <see cref="IGenericEnumerable{T}.GetEnumerator"/>.
        /// </summary>
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Calls <see cref="IGenericEnumerable{T}.GetEnumerator"/>.
        /// </summary>
        [Obsolete("The non-generic '" + nameof(GetEnumerator) + "' should not be used. Use '" + nameof(GetEnumerator) + "<" + nameof(T) + ">' instead.")]
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    }

}
