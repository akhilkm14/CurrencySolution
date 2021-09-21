namespace Currency.Interface
{
    /// <summary>
    /// Amount operations
    /// </summary>
    interface IAmount
    {
        /// <summary>
        /// For printing split down denomination.
        /// </summary>
        public void PrintChange();
    }
}
