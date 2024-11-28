﻿namespace si730ebirriot.API.Inventory.Domain.Model.ValueObjects;

public record SerialNumber(Guid Identifier)
{
    public SerialNumber() : this(Guid.NewGuid())
    {
    }
}

