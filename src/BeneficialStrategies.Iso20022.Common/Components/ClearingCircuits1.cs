// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing circuits information.
/// </summary>
[IsoId("_dWs4gB9zEeapDZRA0Hb6ow")]
[DisplayName("Clearing Circuits")]
public partial record ClearingCircuits1
{
    #nullable enable
    
    /// <summary>
    /// Clearing scheme used.
    /// </summary>
    [IsoId("_lHJ9EB9zEeapDZRA0Hb6ow")]
    [DisplayName("Clearing Circuit")]
    [IsoXmlTag("ClrCrct")]
    public required ClearingScheme1Choice_ ClearingCircuit { get; init; } 
    
    /// <summary>
    /// Indicates whether the limits can be set for the external payment system.
    /// </summary>
    [IsoId("_s5xIUB90EeapDZRA0Hb6ow")]
    [DisplayName("Claim Limit Indicator")]
    [IsoXmlTag("ClmLmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ClaimLimitIndicator { get; init; } 
    
    /// <summary>
    /// Short name of the clearing scheme.
    /// </summary>
    [IsoId("_3LyKsB90EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Scheme Short Name")]
    [IsoXmlTag("ClrSchmeShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public required IsoMax40Text ClearingSchemeShortName { get; init; } 
    
    /// <summary>
    /// Long name of the clearing scheme.
    /// </summary>
    [IsoId("_DkXQ8B91EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Scheme Long Name")]
    [IsoXmlTag("ClrSchmeLngNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text ClearingSchemeLongName { get; init; } 
    
    /// <summary>
    /// Indicates whether all or nothing rule is in effect.
    /// </summary>
    [IsoId("_i_ZUcB91EeapDZRA0Hb6ow")]
    [DisplayName("All Or Nothing Indicator")]
    [IsoXmlTag("AllOrNthgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AllOrNothingIndicator { get; init; } 
    
    /// <summary>
    /// Guarantee funds details.
    /// </summary>
    [IsoId("_8zngcB91EeapDZRA0Hb6ow")]
    [DisplayName("Guarantee Funds")]
    [IsoXmlTag("GrntFnds")]
    public required GuaranteeFunds1 GuaranteeFunds { get; init; } 
    
    /// <summary>
    /// Clearing account identifier.
    /// </summary>
    [IsoId("_UjoHEB94EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public required CashAccount24 ClearingAccount { get; init; } 
    
    /// <summary>
    /// Identification of the clearing account owner.
    /// </summary>
    [IsoId("_fJw_UB94EeapDZRA0Hb6ow")]
    [DisplayName("Clearing Account Owner")]
    [IsoXmlTag("ClrAcctOwnr")]
    public required FinancialInstitutionIdentification9 ClearingAccountOwner { get; init; } 
    
    
    #nullable disable
    
}
