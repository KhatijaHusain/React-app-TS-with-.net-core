using System.ComponentModel;

namespace Domain.Enum
{
    public enum ErrorCodes
    {

        [Description("Domain Error")]
        Domain,

        [Description("Duplicate Error")]
        DuplicateEntity,

        [Description("Not Found Error")]
        EntityNotFound,
    }
}
