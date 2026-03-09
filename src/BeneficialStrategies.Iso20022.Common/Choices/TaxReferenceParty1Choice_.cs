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
    /// Choice of formats for a type of party.
    /// </summary>
    [KnownType(typeof(TaxReferenceParty1Choice.Code))]
    [KnownType(typeof(TaxReferenceParty1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxReferenceParty1Choice.Code),nameof(TaxReferenceParty1Choice.Code))]
    [JsonDerivedType(typeof(TaxReferenceParty1Choice.Proprietary),nameof(TaxReferenceParty1Choice.Proprietary))]
    #endif
    [IsoId("_6PWX4E4REeiQHa-q1Uephw")]
    [DisplayName("Tax Reference Party 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxReferenceParty1Choice_
    #else
    public abstract partial class TaxReferenceParty1Choice_
    #endif
    {
    }
}
