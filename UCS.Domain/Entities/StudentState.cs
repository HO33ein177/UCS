namespace UCS.Domain.Entities;

[Flags]
public enum StudentState
{
    None = 0,                      // No state
    GpaAboveA = 1 << 0,            // 1
    Conditional = 1 << 1,          // 2
    LastSemester = 1 << 2,         // 4
    InDebt = 1 << 3,               // 8
    MustPayTuition = 1 << 4,       // 16
    TuitionFree = 1 << 5
}

