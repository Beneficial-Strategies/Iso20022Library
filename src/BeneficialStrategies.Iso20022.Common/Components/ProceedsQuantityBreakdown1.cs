// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proceeds Quantity Breakdown1.
/// </summary>
[IsoId("_BH4C0IYfEe-haozGYc1X7Q")]
[DisplayName("Proceeds Quantity Breakdown1")]
public partial record ProceedsQuantityBreakdown1
{
    #nullable enable

    /// <summary>
    /// Cash Compensation Quantity.
    /// </summary>
    [DisplayName("Cash Compensation Quantity")]
    [IsoXmlTag("CshCompstnQty")]
    public FinancialInstrumentQuantity18Choice_? CashCompensationQuantity { get; init; } 

    /// <summary>
    /// Transfer Of Received Proceeds Quantity.
    /// </summary>
    [DisplayName("Transfer Of Received Proceeds Quantity")]
    [IsoXmlTag("TrfOfRcvdPrcdsQty")]
    public FinancialInstrumentQuantity18Choice_? TransferOfReceivedProceedsQuantity { get; init; } 

    
    #nullable disable
    
}
