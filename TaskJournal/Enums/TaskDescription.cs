using System.ComponentModel;

namespace TaskJournal.Enums;

public enum TaskDescription
{
    [Description("ACCIDENT")]
    ACCIDENT,
    [Description("SCHEDULED")]
    SCHEDULED,
    [Description("REQUESTED")]
    REQUESTED
}