using System;

namespace API.DTOs;

public class MemberUpdateDto
{
    public string? introduction { get; set; }
    public string? LookingFor { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
}
