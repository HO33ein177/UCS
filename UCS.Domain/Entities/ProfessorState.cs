namespace UCS.Domain.Entities;

[Flags]
public enum ProfessorState
{
    None = 0,
    
    ScientificBoardMember = 1 << 0,    // 1
    
    Educator = 1 << 1,                  // 2
    AssistantProfessor = 1 << 2,        // 4
    AssociateProfessor = 1 << 3,        // 8
    FullProfessor = 1 << 4,             // 16
    
    PartTime = 1 << 5,                  // 32
    FullTime = 1 << 6,                  // 64
    
    PaidOnContract = 1 << 7,            // 128
    PaidHourly = 1 << 8                 // 256
}