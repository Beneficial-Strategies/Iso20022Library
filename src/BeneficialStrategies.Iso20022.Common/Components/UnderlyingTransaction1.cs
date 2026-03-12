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
[IsoId("_PmjjStp-Ed-ak6NoX_4Aeg_-1321126765")]
[DisplayName("Underlying Transaction")]
public partial record UnderlyingTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage, to which the cancellation refers.
    /// </summary>
    [IsoId("_PmjjS9p-Ed-ak6NoX_4Aeg_-1321126455")]
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupInformation23? OriginalGroupInformationAndCancellation { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [IsoId("_PmjjTNp-Ed-ak6NoX_4Aeg_-1321126363")]
    [DisplayName("Original Payment Information And Cancellation")]
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    public OriginalPaymentInformation4? OriginalPaymentInformationAndCancellation { get; init; } 
    
    
    #nullable disable
    
}
