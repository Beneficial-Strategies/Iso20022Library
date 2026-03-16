// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specifying the Mandate.
/// </summary>
[IsoId("_a6CSAQ4aEeKGXqvMN6jpiw")]
[DisplayName("Operation Mandate")]
public record OperationMandate2
{
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    [IsoId("_bPfkpQ4aEeKGXqvMN6jpiw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Channel for which the operation mandate is valid. If ApplicableChannel equals Fax, this means that a bank operation instruction sent by fax will be processed according to the mandates exchanged in this message.
    /// </summary>
    [IsoId("_hdVCcBg3EeKnW4lR85q-0A")]
    [DisplayName("Applicable Channel")]
    [IsoXmlTag("AplblChanl")]
    public ValueList<Channel2Choice_> ApplicableChannel { get; init; } = [];

    // ID for the above is _hdVCcBg3EeKnW4lR85q-0A

    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    [IsoId("_bPfkrA4aEeKGXqvMN6jpiw")]
    [DisplayName("Required Signature Number")]
    [IsoXmlTag("ReqrdSgntrNb")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; }

    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    [IsoId("_bPfksw4aEeKGXqvMN6jpiw")]
    [DisplayName("Signature Order Indicator")]
    [IsoXmlTag("SgntrOrdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; }

    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    [IsoId("_bPfkug4aEeKGXqvMN6jpiw")]
    [DisplayName("Mandate Holder")]
    [IsoXmlTag("MndtHldr")]
    public PartyAndAuthorisation1? MandateHolder { get; init; }

    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    [IsoId("_bPfkwQ4aEeKGXqvMN6jpiw")]
    [DisplayName("Bank Operation")]
    [IsoXmlTag("BkOpr")]
    public ValueList<BankTransactionCodeStructure4> BankOperation { get; init; } = [];

    // ID for the above is _bPfkwQ4aEeKGXqvMN6jpiw

    /// <summary>
    /// Is the date when the mandate becomes valid.
    /// </summary>
    [IsoId("_bPfkyA4aEeKGXqvMN6jpiw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Is the date when the mandate stops to be valid.
    /// </summary>
    [IsoId("_bPfkzw4aEeKGXqvMN6jpiw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }
}
