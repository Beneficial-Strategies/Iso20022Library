// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[IsoId("_PmstQtp-Ed-ak6NoX_4Aeg_-1329439131")]
[DisplayName("Underlying Transaction")]
public partial record UnderlyingTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage, to which the cancellation refers.
    /// </summary>
    [IsoId("_PmstQ9p-Ed-ak6NoX_4Aeg_-1329439038")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupInformation23? OriginalGroupInformationAndCancellation { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_PmstRNp-Ed-ak6NoX_4Aeg_-1329438698")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public PaymentTransactionInformation31? TransactionInformation { get; init; } 
    
    
    #nullable disable
    
}
