// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_MKVgwWRPEeqImsG9JNoSQw")]
[DisplayName("Tracker Header")]
public record TrackerHeader5
{
    /// <summary>
    /// Point to point reference, as assigned by the tracker informing party and sent by the tracker to unambiguously identify the message.
    /// </summary>
    [IsoId("_MVIbgWRPEeqImsG9JNoSQw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_MVIbg2RPEeqImsG9JNoSQw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_MVIbhWRPEeqImsG9JNoSQw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Party that provides information on the status and related details of a transaction.
    /// </summary>
    [IsoId("_MVIbh2RPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; }

    /// <summary>
    /// Party that is updated on the status and related details of a transaction.
    /// </summary>
    [IsoId("_MVIbiWRPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informed Party")]
    [IsoXmlTag("TrckrInfrmdPty")]
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; }

    /// <summary>
    /// Original reference, as assigned by the informer and sent to the tracker to unambiguously identify the tracker update message.
    /// Usage: this element may only be present when the alert notification is related to a payment status tracker update.
    /// </summary>
    [IsoId("_MVIbi2RPEeqImsG9JNoSQw")]
    [DisplayName("Original Tracker Update")]
    [IsoXmlTag("OrgnlTrckrUpd")]
    public OriginalBusinessInstruction1? OriginalTrackerUpdate { get; init; }

    /// <summary>
    /// Agreement under which or rules under which the tracker update should be processed.
    /// </summary>
    [IsoId("_MVIbjWRPEeqImsG9JNoSQw")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }
}
