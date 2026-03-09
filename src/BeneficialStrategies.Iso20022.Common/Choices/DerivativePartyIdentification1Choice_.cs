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
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name credit default swap (CDS).
    /// </summary>
    [KnownType(typeof(DerivativePartyIdentification1Choice.Country))]
    [KnownType(typeof(DerivativePartyIdentification1Choice.CountrySubDivision))]
    [KnownType(typeof(DerivativePartyIdentification1Choice.LEI))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DerivativePartyIdentification1Choice.Country),nameof(DerivativePartyIdentification1Choice.Country))]
    [JsonDerivedType(typeof(DerivativePartyIdentification1Choice.CountrySubDivision),nameof(DerivativePartyIdentification1Choice.CountrySubDivision))]
    [JsonDerivedType(typeof(DerivativePartyIdentification1Choice.LEI),nameof(DerivativePartyIdentification1Choice.LEI))]
    #endif
    [IsoId("_adARgEW8EeWaZZ6gWK8UVw")]
    [DisplayName("Derivative Party Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DerivativePartyIdentification1Choice_
    #else
    public abstract partial class DerivativePartyIdentification1Choice_
    #endif
    {
    }
}
