﻿namespace SpaManagementSystem.Application.Requests.Service;

public record UpdateServiceRequest(
    string Name,
    string Code,
    string? Description,
    decimal Price,
    decimal TaxRate,
    TimeSpan Duration,
    string? ImgUrl,
    bool IsActive);