// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option protect level.
/// </summary>
[IsoId("_KY-t8b-0Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Instructed Balance Option Protect Instruction Details SD")]
public record CorporateActionInstructedBalanceOptionProtectInstructionDetailsSD2
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_KoTjYb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Option number of the protect instruction.
    /// </summary>
    [IsoId("_KoTjZ7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Instruction reference number assigned by DTC to the uncovered protect instruction.
    /// </summary>
    [IsoId("_KoTjY7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification")]
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15Text ProtectIdentification { get; init; }

    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_5vrDseZSEeewObBhnieI_A")]
    [DisplayName("Protect Safekeeping Account")]
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; }

    /// <summary>
    /// Additional reference number used to uniquely identify uncovered protect instruction.
    /// </summary>
    [IsoId("_KoTjZb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Sequence Number")]
    [IsoXmlTag("PrtctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ProtectSequenceNumber { get; init; }

    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_KoTjb7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ProtectDate { get; init; }

    /// <summary>
    /// Date and time of the cover protect. Will be the latest cover date if partial cover transaction occurs.
    /// </summary>
    [IsoId("_KoTjcb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CoverProtectDate { get; init; }

    /// <summary>
    /// Quantity of the protect instruction. For protects which are partially covered, the quantity will be reduced by the amount partially covered.
    /// </summary>
    [IsoId("_KoTjc7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Quantity")]
    [IsoXmlTag("PrtctIdQty")]
    public required FinancialInstrumentQuantity15Choice_ ProtectIdentificationQuantity { get; init; }

    /// <summary>
    /// Quantity of the protect instruction which has not been covered.
    /// </summary>
    [IsoId("_KoTjdb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Uncovered Quantity")]
    [IsoXmlTag("PrtctIdUcvrdQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; }

    /// <summary>
    /// Protect oversubscription quantity.
    /// </summary>
    [IsoId("_KoTjd7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Oversubscription Quantity")]
    [IsoXmlTag("PrtctIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_KoTjeb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Status")]
    [IsoXmlTag("PrtctIdSts")]
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; }

    /// <summary>
    /// Conditional quantity for the protect instruction.
    /// </summary>
    [IsoId("_KoTje7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Conditional Quantity")]
    [IsoXmlTag("PrtctCondlQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectConditionalQuantity { get; init; }

    /// <summary>
    /// Tender bid price of the protect instruction.
    /// </summary>
    [IsoId("_KoTjfb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Tender Bid Price")]
    [IsoXmlTag("PrtctTndrBidPric")]
    public PriceFormat57Choice_? ProtectTenderBidPrice { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_KoTjf7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    [IsoId("_252Z8b_uEeeb2ZBoAlSG1Q")]
    [DisplayName("Instruction Comments")]
    [IsoXmlTag("InstrCmnts")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? InstructionComments { get; init; }
}
