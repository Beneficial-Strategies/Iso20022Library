// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original group, to which the message refers.
/// </summary>
[IsoId("_Plz8aNp-Ed-ak6NoX_4Aeg_160183350")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation23
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the group cancellation request.||Usage: The group cancellation request identification can be used for reconciliation or to link tasks related to the cancellation request.
    /// </summary>
    [IsoId("_Plz8adp-Ed-ak6NoX_4Aeg_1959655948")]
    [DisplayName("Group Cancellation Identification")]
    [IsoXmlTag("GrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GroupCancellationIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    [IsoId("_Plz8atp-Ed-ak6NoX_4Aeg_752615022")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case2? Case { get; init; } 
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_Plz8a9p-Ed-ak6NoX_4Aeg_161103352")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_Plz8bNp-Ed-ak6NoX_4Aeg_161103413")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_Pl9GUNp-Ed-ak6NoX_4Aeg_161103443")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_Pl9GUdp-Ed-ak6NoX_4Aeg_-1798745200")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_Pl9GUtp-Ed-ak6NoX_4Aeg_1901473007")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Indicates whether the cancellation request applies to a whole group of transactions or to individual transactions within an original group.
    /// </summary>
    [IsoId("_Pl9GU9p-Ed-ak6NoX_4Aeg_1901473068")]
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    public IsoGroupCancellationIndicator? GroupCancellation { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_Pl9GVNp-Ed-ak6NoX_4Aeg_161103598")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public CancellationReasonInformation3? CancellationReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
