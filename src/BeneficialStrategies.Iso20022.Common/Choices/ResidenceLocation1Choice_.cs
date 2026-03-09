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
    /// Choice of location of a residence of a party.
    /// </summary>
    [KnownType(typeof(ResidenceLocation1Choice.Country))]
    [KnownType(typeof(ResidenceLocation1Choice.Area))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResidenceLocation1Choice.Country),nameof(ResidenceLocation1Choice.Country))]
    [JsonDerivedType(typeof(ResidenceLocation1Choice.Area),nameof(ResidenceLocation1Choice.Area))]
    #endif
    [IsoId("_6QsqkpqlEeGSON8vddiWzQ_1947299018")]
    [DisplayName("Residence Location 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResidenceLocation1Choice_
    #else
    public abstract partial class ResidenceLocation1Choice_
    #endif
    {
    }
}
