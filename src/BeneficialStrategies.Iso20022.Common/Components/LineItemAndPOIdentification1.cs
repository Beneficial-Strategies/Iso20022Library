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
/// Identifies the line item number and the purchase order.
/// </summary>
[IsoId("_RaVOBdp-Ed-ak6NoX_4Aeg_-1742051329")]
[DisplayName("Line Item And PO Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemAndPOIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItemAndPOIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItemAndPOIdentification1( DocumentIdentification7 reqPurchaseOrderReference )
    {
        PurchaseOrderReference = reqPurchaseOrderReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    [IsoId("_RaVOBtp-Ed-ak6NoX_4Aeg_-1638617880")]
    [DisplayName("Line Item Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItmId")]
    #endif
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    public SimpleValueList<System.String> LineItemIdentification { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RaVOBtp-Ed-ak6NoX_4Aeg_-1638617880
    
    /// <summary>
    /// Reference to the purchase order containing the line item.
    /// </summary>
    [IsoId("_RaVOB9p-Ed-ak6NoX_4Aeg_-1399423976")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
