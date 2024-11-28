﻿using si730ebirriot.API.Inventory.Domain.Model.Aggregates;
using si730ebirriot.API.Inventory.Domain.Model.ValueObjects;

namespace si730ebirriot.API.Inventory.Domain.Repositories;

/// <summary>
/// Repository for Things.
/// </summary>
public interface IThingRepository
{
    /// <summary>
    /// Verifies if a Thing exists by its serial number.
    /// </summary>
    /// <param name="serialNumber">
    /// The serial number of the Thing.
    /// </param>
    /// <returns>
    /// True if the Thing exists, false otherwise.
    /// </returns>
    Task<bool> ExistsBySerialNumberAsync(SerialNumber serialNumber);
    
    /// <summary>
    /// Obtains a Thing by its id number.
    /// </summary>
    /// <param name="id">
    /// The id of the Thing.
    /// </param>
    /// <returns>
    /// The Thing with the given id.
    /// </returns>
    Task<Thing> GetByIdAsync(int id);
}