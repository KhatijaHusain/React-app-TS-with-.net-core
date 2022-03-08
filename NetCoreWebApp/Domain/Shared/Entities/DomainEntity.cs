namespace Domain.Shared.Entities
{
    public class DomainEntity<TKey> where TKey : DomainEntity<TKey>
    {
        private TKey commentid;

        public DomainEntity()
        {
        }

        public virtual TKey CommentId
        {
            get
            {
                return commentid;
            }
            protected set
            {
                commentid = value;
            }
        }       
    }
}