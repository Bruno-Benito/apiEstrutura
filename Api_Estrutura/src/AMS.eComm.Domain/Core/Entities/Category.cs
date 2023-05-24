namespace AMS.eComm.Domain.Core.Entities
{
    public class Category
    {
        #region Constructors
            public Category(){}

            public Category(Guid id,string description, bool isActive)
            {
                Id = id;
                Description = description;
                IsActive = isActive;
            }
        #endregion
        public Guid Id { get; set; }
        public string Description { get; set; }

        public bool IsActive;
    }
}