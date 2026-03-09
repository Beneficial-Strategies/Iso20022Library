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
    /// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposalResponse4Choice.CollateralProposal))]
    [KnownType(typeof(CollateralProposalResponse4Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralProposalResponse4Choice.CollateralProposal),nameof(CollateralProposalResponse4Choice.CollateralProposal))]
    [JsonDerivedType(typeof(CollateralProposalResponse4Choice.SegregatedIndependentAmount),nameof(CollateralProposalResponse4Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_vsq8gStIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Proposal Response 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralProposalResponse4Choice_
    #else
    public abstract partial class CollateralProposalResponse4Choice_
    #endif
    {
    }
}
