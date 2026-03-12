// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the information to comply with.
/// </summary>
[IsoId("_chfbP5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Narrative")]
public partial record CorporateActionNarrative33
{
    #nullable enable
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or Sophisticated Investor Letter (SIL) to be provided.
    /// </summary>
    [IsoId("_chfbQZKQEeWHWpTQn1FFVg")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InformationToComplyWith { get; init; } 
    
    /// <summary>
    /// Provides additional information on the delivery details of the outturned (derived) securities. This narrative is only to be used in case the securities are not eligible at the agent/custodian, and may not be used for settlement instructions.
    /// </summary>
    [IsoId("_chfbSZKQEeWHWpTQn1FFVg")]
    [DisplayName("Delivery Details")]
    [IsoXmlTag("DlvryDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? DeliveryDetails { get; init; } 
    
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_chfbUZKQEeWHWpTQn1FFVg")]
    [DisplayName("Foreign Exchange Instructions Additional Information")]
    [IsoXmlTag("FXInstrsAddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? ForeignExchangeInstructionsAdditionalInformation { get; init; } 
    
    /// <summary>
    /// Provides additional details pertaining to the corporate action instruction.
    /// </summary>
    [IsoId("_chfbWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Additional Information")]
    [IsoXmlTag("InstrAddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionAdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
