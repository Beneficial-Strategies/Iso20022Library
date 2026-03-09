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
    /// Jurisdiction of the issuer of the security used as collateral. 
    /// </summary>
    [KnownType(typeof(IssuerJurisdiction1Choice.CountryCode))]
    [KnownType(typeof(IssuerJurisdiction1Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IssuerJurisdiction1Choice.CountryCode),nameof(IssuerJurisdiction1Choice.CountryCode))]
    [JsonDerivedType(typeof(IssuerJurisdiction1Choice.Other),nameof(IssuerJurisdiction1Choice.Other))]
    #endif
    [IsoId("_qFVoIIfXEeu9_PKSQNOmdg")]
    [DisplayName("Issuer Jurisdiction 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IssuerJurisdiction1Choice_
    #else
    public abstract partial class IssuerJurisdiction1Choice_
    #endif
    {
    }
}
