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
    [KnownType(typeof(CollateralProposal4Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposal4Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralProposal4Choice.CollateralProposalDetails),nameof(CollateralProposal4Choice.CollateralProposalDetails))]
    [JsonDerivedType(typeof(CollateralProposal4Choice.SegregatedIndependentAmount),nameof(CollateralProposal4Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_xZ6mlYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Proposal 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralProposal4Choice_
    #else
    public abstract partial class CollateralProposal4Choice_
    #endif
    {
    }
}
