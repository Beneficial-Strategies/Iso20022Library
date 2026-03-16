// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Group Header23.
/// </summary>
[IsoId("_73Gb8TEyEe6g-ffJsqGiSA")]
[DisplayName("Original Group Header23")]
public partial record OriginalGroupHeader23
{
    #nullable enable

    /// <summary>
    /// Cancellation Status Reason Information.
    /// </summary>
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReason5> CancellationStatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Group Cancellation Status.
    /// </summary>
    [DisplayName("Group Cancellation Status")]
    [IsoXmlTag("GrpCxlSts")]
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; } 

    /// <summary>
    /// Number Of Transactions Per Cancellation Status.
    /// </summary>
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public ValueList<NumberOfTransactionsPerStatus1> NumberOfTransactionsPerCancellationStatus { get; init; } = [];

    /// <summary>
    /// Original Control Sum.
    /// </summary>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 

    /// <summary>
    /// Original Creation Date Time.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 

    /// <summary>
    /// Original Group Cancellation Identification.
    /// </summary>
    [DisplayName("Original Group Cancellation Identification")]
    [IsoXmlTag("OrgnlGrpCxlId")]
    public IsoMax35Text? OriginalGroupCancellationIdentification { get; init; } 

    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 

    /// <summary>
    /// Original Message Name Identification.
    /// </summary>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 

    /// <summary>
    /// Original Number Of Transactions.
    /// </summary>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 

    /// <summary>
    /// Resolved Case.
    /// </summary>
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case6? ResolvedCase { get; init; } 

    
    #nullable disable
    
}
