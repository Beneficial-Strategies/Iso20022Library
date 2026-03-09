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
/// Provides detailed shareholding balance information for an account.
/// </summary>
[IsoId("_lprEMDttEemIf7eyjCwinw")]
[DisplayName("Shareholding Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShareholdingBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ShareholdingBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShareholdingBalance1( ShareholdingType1Code reqShareholdingType,FinancialInstrumentQuantity18Choice_ reqQuantity )
    {
        ShareholdingType = reqShareholdingType;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the category of shareholding.
    /// </summary>
    [IsoId("_pv8WADttEemIf7eyjCwinw")]
    [DisplayName("Shareholding Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldgTp")]
    #endif
    [IsoXmlTag("ShrhldgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShareholdingType1Code ShareholdingType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShareholdingType1Code ShareholdingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShareholdingType1Code ShareholdingType { get; init; } 
    #else
    public ShareholdingType1Code ShareholdingType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of shares of this type of shareholding or with this date of shareholding held by the account owner.
    /// </summary>
    [IsoId("_JW05YD59EemPvNTzinB5Vw")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity18Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity18Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date as from when the shares have been held by the shareholder on its account.
    /// </summary>
    [IsoId("_IZQocD5-EemPvNTzinB5Vw")]
    [DisplayName("Initial Date Of Shareholding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlDtOfShrhldg")]
    #endif
    [IsoXmlTag("InitlDtOfShrhldg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat57Choice_? InitialDateOfShareholding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat57Choice_? InitialDateOfShareholding { get; init; } 
    #else
    public DateFormat57Choice_? InitialDateOfShareholding { get; set; } 
    #endif
    
    /// <summary>
    /// Third party who is authorised to take specific actions on behalf of the shareholder.
    /// </summary>
    [IsoId("_ssY78D6BEemPvNTzinB5Vw")]
    [DisplayName("Third Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPty")]
    #endif
    [IsoXmlTag("ThrdPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification218? ThirdParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification218? ThirdParty { get; init; } 
    #else
    public PartyIdentification218? ThirdParty { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4CPcET6QEemPvNTzinB5Vw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
