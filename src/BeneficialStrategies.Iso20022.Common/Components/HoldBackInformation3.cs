// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about hold back and gating.
/// </summary>
[IsoId("_PwkDkawIEeaFSqx7FdVuJQ")]
[DisplayName("Hold Back Information")]
public partial record HoldBackInformation3
{
    #nullable enable
    
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    [IsoId("_QII2EawIEeaFSqx7FdVuJQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GateHoldBack1Code Type { get; init; } 
    
    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    [IsoId("_QII2E6wIEeaFSqx7FdVuJQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    [IsoId("_QII2FawIEeaFSqx7FdVuJQ")]
    [DisplayName("Expected Release Date")]
    [IsoXmlTag("XpctdRlsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedReleaseDate { get; init; } 
    
    /// <summary>
    /// New identification of the security.
    /// </summary>
    [IsoId("_QII2F6wIEeaFSqx7FdVuJQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// New name of the security.
    /// </summary>
    [IsoId("_QII2GawIEeaFSqx7FdVuJQ")]
    [DisplayName("Financial Instrument Name")]
    [IsoXmlTag("FinInstrmNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentName { get; init; } 
    
    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    [IsoId("_QII2IawIEeaFSqx7FdVuJQ")]
    [DisplayName("Redemption Completion")]
    [IsoXmlTag("RedCmpltn")]
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; } 
    
    
    #nullable disable
    
}
