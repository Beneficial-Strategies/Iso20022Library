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
    /// Defines how the CSD is linked to the security.
    /// </summary>
    [KnownType(typeof(IssuerOrInvestor1Choice.IssuerCSD))]
    [KnownType(typeof(IssuerOrInvestor1Choice.InvestorCSD))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IssuerOrInvestor1Choice.IssuerCSD),nameof(IssuerOrInvestor1Choice.IssuerCSD))]
    [JsonDerivedType(typeof(IssuerOrInvestor1Choice.InvestorCSD),nameof(IssuerOrInvestor1Choice.InvestorCSD))]
    #endif
    [IsoId("_hh_UoWliEeGaMcKyqKNRfQ_1655812261")]
    [DisplayName("Issuer Or Investor 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IssuerOrInvestor1Choice_
    #else
    public abstract partial class IssuerOrInvestor1Choice_
    #endif
    {
    }
}
