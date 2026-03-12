// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_PmG3Xdp-Ed-ak6NoX_4Aeg_-1414031304")]
[DisplayName("Original Payment Information")]
public partial record OriginalPaymentInformation3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    [IsoId("_PmQoUNp-Ed-ak6NoX_4Aeg_-1414031273")]
    [DisplayName("Original Payment Information Cancellation Identification")]
    [IsoXmlTag("OrgnlPmtInfCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_PmQoUdp-Ed-ak6NoX_4Aeg_-1414030447")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case2? ResolvedCase { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_PmQoUtp-Ed-ak6NoX_4Aeg_-1414031243")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_PmQoU9p-Ed-ak6NoX_4Aeg_-1414030871")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_PmQoVNp-Ed-ak6NoX_4Aeg_-1414030941")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_PmQoVdp-Ed-ak6NoX_4Aeg_-1414031212")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    
    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    [IsoId("_PmQoVtp-Ed-ak6NoX_4Aeg_-1414030964")]
    [DisplayName("Payment Information Cancellation Status")]
    [IsoXmlTag("PmtInfCxlSts")]
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_PmQoV9p-Ed-ak6NoX_4Aeg_-1323465127")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReasonInformation1? CancellationStatusReasonInformation { get; init; } 
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_PmZyQNp-Ed-ak6NoX_4Aeg_-1323465073")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_PmZyQdp-Ed-ak6NoX_4Aeg_-1414030818")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public PaymentTransactionInformation32? TransactionInformationAndStatus { get; init; } 
    
    
    #nullable disable
    
}
