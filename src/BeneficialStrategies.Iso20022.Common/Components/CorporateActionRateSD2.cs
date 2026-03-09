// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio of the American or Global Depository Receipt(s) per ordinary share(s).
/// </summary>
[IsoId("_1hE44DL3EeKU9IrkkToqcw_-385014275")]
[DisplayName("Corporate Action Rate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRateSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Receipts quantity (base) of the American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1hE44TL3EeKU9IrkkToqcw_-599097563")]
    [DisplayName("Receipt Base Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctBaseQty")]
    #endif
    [IsoXmlTag("RctBaseQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ReceiptBaseQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ReceiptBaseQuantity { get; init; } 
    #else
    public System.UInt64? ReceiptBaseQuantity { get; set; } 
    #endif
    
    /// <summary>
    ///  Ordinary shares quantity of the American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1hE44jL3EeKU9IrkkToqcw_1099881985")]
    [DisplayName("Ordinary Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdnryShr")]
    #endif
    [IsoXmlTag("OrdnryShr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? OrdinaryShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OrdinaryShare { get; init; } 
    #else
    public System.UInt64? OrdinaryShare { get; set; } 
    #endif
    
    
    #nullable disable
    
}
