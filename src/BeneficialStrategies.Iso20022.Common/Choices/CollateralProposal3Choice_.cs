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
    /// Provides details about the proposal for the variation margin and optionaly the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposal3Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposal3Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralProposal3Choice.CollateralProposalDetails),nameof(CollateralProposal3Choice.CollateralProposalDetails))]
    [JsonDerivedType(typeof(CollateralProposal3Choice.SegregatedIndependentAmount),nameof(CollateralProposal3Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_PYHrBV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Proposal 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralProposal3Choice_
    #else
    public abstract partial class CollateralProposal3Choice_
    #endif
    {
    }
}
