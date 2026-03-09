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
    /// Identifies the response parameters for which there is a match with the search criteria.
    /// </summary>
    [KnownType(typeof(InvestigatedParties1Choice.Code))]
    [KnownType(typeof(InvestigatedParties1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigatedParties1Choice.Code),nameof(InvestigatedParties1Choice.Code))]
    [JsonDerivedType(typeof(InvestigatedParties1Choice.Proprietary),nameof(InvestigatedParties1Choice.Proprietary))]
    #endif
    [IsoId("_cRD_EzwTEeGKuZXNQxGH3g")]
    [DisplayName("Investigated Parties 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigatedParties1Choice_
    #else
    public abstract partial class InvestigatedParties1Choice_
    #endif
    {
    }
}
