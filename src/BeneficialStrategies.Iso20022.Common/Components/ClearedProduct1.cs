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
/// Financial instrument cleared by a central counterparty.
/// </summary>
[IsoId("_vcwiQLVNEeadLcJesEbkTQ")]
[DisplayName("Cleared Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearedProduct1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearedProduct1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearedProduct1( GenericIdentification168 reqCCPProductIdentification,Product1Choice_ reqProduct,OpenInterest1 reqOpenInterest )
    {
        CCPProductIdentification = reqCCPProductIdentification;
        Product = reqProduct;
        OpenInterest = reqOpenInterest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Exchange or trading venue where product is traded.
    /// </summary>
    [IsoId("__o5ZsLVNEeadLcJesEbkTQ")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public SimpleValueList<System.String> TradingVenue { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is __o5ZsLVNEeadLcJesEbkTQ
    
    /// <summary>
    /// CCP&apos;s unique identification for product cleared.
    /// </summary>
    [IsoId("_DsqKELVOEeadLcJesEbkTQ")]
    [DisplayName("CCP Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCPPdctId")]
    #endif
    [IsoXmlTag("CCPPdctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification168 CCPProductIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification168 CCPProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification168 CCPProductIdentification { get; init; } 
    #else
    public GenericIdentification168 CCPProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Standard unique identification of product cleared.
    /// </summary>
    [IsoId("__int0MhtEeadgvwNGwK05w")]
    [DisplayName("Universal Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UvrslPdctId")]
    #endif
    [IsoXmlTag("UvrslPdctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification168? UniversalProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification168? UniversalProductIdentification { get; init; } 
    #else
    public GenericIdentification168? UniversalProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between the major categories of financial instruments.
    /// </summary>
    [IsoId("__Z5e8LVOEeadLcJesEbkTQ")]
    [DisplayName("Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdct")]
    #endif
    [IsoXmlTag("Pdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Product1Choice_ Product { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Product1Choice_ Product { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product1Choice_ Product { get; init; } 
    #else
    public Product1Choice_ Product { get; set; } 
    #endif
    
    /// <summary>
    /// Measure of the current stock of a financial instrument that has been traded on an exchange or cleared via a central counterparty.
    /// </summary>
    [IsoId("_Q99nELVZEeadLcJesEbkTQ")]
    [DisplayName("Open Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnIntrst")]
    #endif
    [IsoXmlTag("OpnIntrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OpenInterest1 OpenInterest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OpenInterest1 OpenInterest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpenInterest1 OpenInterest { get; init; } 
    #else
    public OpenInterest1 OpenInterest { get; set; } 
    #endif
    
    /// <summary>
    /// Number of trades cleared over the reporting period.
    /// </summary>
    [IsoId("_xGV_EPqBEeaQh_7a05rSJQ")]
    [DisplayName("Trades Cleared")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrdsClrd")]
    #endif
    [IsoXmlTag("TrdsClrd")]
    [IsoSimpleType(IsoSimpleType.NonNegativeNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNonNegativeNumber? TradesCleared { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TradesCleared { get; init; } 
    #else
    public System.UInt64? TradesCleared { get; set; } 
    #endif
    
    
    #nullable disable
    
}
