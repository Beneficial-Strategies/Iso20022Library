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
    [KnownType(typeof(CollateralProposalResponse1Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposalResponse1Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralProposalResponse1Choice.CollateralProposalDetails),nameof(CollateralProposalResponse1Choice.CollateralProposalDetails))]
    [JsonDerivedType(typeof(CollateralProposalResponse1Choice.SegregatedIndependentAmount),nameof(CollateralProposalResponse1Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_QmU-Ndp-Ed-ak6NoX_4Aeg_651195634")]
    [DisplayName("Collateral Proposal Response 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralProposalResponse1Choice_
    #else
    public abstract partial class CollateralProposalResponse1Choice_
    #endif
    {
    }
}
