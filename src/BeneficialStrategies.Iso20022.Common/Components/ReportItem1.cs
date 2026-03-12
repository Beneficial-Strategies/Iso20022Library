// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account details of the report item.
/// </summary>
[IsoId("_Xtn_QU1oEeSvz4A_x0ui8g")]
[DisplayName("Report Item")]
public partial record ReportItem1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_xqlbEU1pEeSvz4A_x0ui8g")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Level of the safekeeping account or sub-account of the report item.
    /// </summary>
    [IsoId("_Qv8mAE1pEeSvz4A_x0ui8g")]
    [DisplayName("Account Level")]
    [IsoXmlTag("AcctLvl")]
    public required HoldingAccountLevel1Code AccountLevel { get; init; } 
    
    /// <summary>
    /// Financial instrument identification of the report item.
    /// </summary>
    [IsoId("_ia7aAU1pEeSvz4A_x0ui8g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Date of the report item.
    /// </summary>
    [IsoId("_kotgMU1pEeSvz4A_x0ui8g")]
    [DisplayName("Item Date")]
    [IsoXmlTag("ItmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ItemDate { get; init; } 
    
    
    #nullable disable
    
}
