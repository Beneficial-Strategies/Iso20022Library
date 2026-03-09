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
/// Information about the securities movements.
/// </summary>
[IsoId("_UIYIptp-Ed-ak6NoX_4Aeg_1464286927")]
[DisplayName("Corporate Action Securities Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSecuritiesMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionSecuritiesMovement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionSecuritiesMovement1( SecurityIdentification7 reqSecurityIdentification,UnitOrFaceAmount1Choice_ reqPostingQuantity )
    {
        SecurityIdentification = reqSecurityIdentification;
        PostingQuantity = reqPostingQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time of the posting.
    /// </summary>
    [IsoId("_UIYIp9p-Ed-ak6NoX_4Aeg_1643449957")]
    [DisplayName("Posting Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDtTm")]
    #endif
    [IsoXmlTag("PstngDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PostingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIYIqNp-Ed-ak6NoX_4Aeg_1698861252")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities that is posted.
    /// </summary>
    [IsoId("_UIYIqdp-Ed-ak6NoX_4Aeg_1987000696")]
    [DisplayName("Posting Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngQty")]
    #endif
    [IsoXmlTag("PstngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ PostingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UIh5oNp-Ed-ak6NoX_4Aeg_-1695911196")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount8> AccountDetails { get; init; } = new ValueList<SecuritiesAccount8>(){};
    
    
    #nullable disable
    
}
