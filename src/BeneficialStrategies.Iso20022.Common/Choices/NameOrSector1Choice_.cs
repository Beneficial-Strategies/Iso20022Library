// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the reported party through the name or the sector.
    /// </summary>
    [KnownType(typeof(NameOrSector1Choice.Name))]
    [KnownType(typeof(NameOrSector1Choice.Sector))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NameOrSector1Choice.Name),nameof(NameOrSector1Choice.Name))]
    [JsonDerivedType(typeof(NameOrSector1Choice.Sector),nameof(NameOrSector1Choice.Sector))]
    #endif
    [IsoId("_6MuWYYInEeWA9fc11zJf1Q")]
    [DisplayName("Name Or Sector 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NameOrSector1Choice_
    #else
    public abstract partial class NameOrSector1Choice_
    #endif
    {
    }
}
