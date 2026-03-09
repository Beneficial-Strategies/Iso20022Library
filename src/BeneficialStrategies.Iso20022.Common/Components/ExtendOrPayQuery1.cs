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
/// Undertaking extend or pay query details.
/// </summary>
[IsoId("_-Des53ltEeG7BsjMvd1mEw_2002292702")]
[DisplayName("Extend Or Pay Query")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtendOrPayQuery1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExtendOrPayQuery1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtendOrPayQuery1( Undertaking9 reqUndertakingIdentification,Demand2 reqDemandDetails,System.DateOnly reqRequestedExpiryDate )
    {
        UndertakingIdentification = reqUndertakingIdentification;
        DemandDetails = reqDemandDetails;
        RequestedExpiryDate = reqRequestedExpiryDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Des6HltEeG7BsjMvd1mEw_-1747808883")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking9 UndertakingIdentification { get; init; } 
    #else
    public Undertaking9 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-Dn20HltEeG7BsjMvd1mEw_554766845")]
    [DisplayName("Demand Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndDtls")]
    #endif
    [IsoXmlTag("DmndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Demand2 DemandDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Demand2 DemandDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Demand2 DemandDetails { get; init; } 
    #else
    public Demand2 DemandDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new expiry date as an alternative to payment of the demand.
    /// </summary>
    [IsoId("_-Dn20XltEeG7BsjMvd1mEw_2099672583")]
    [DisplayName("Requested Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdXpryDt")]
    #endif
    [IsoXmlTag("ReqdXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate RequestedExpiryDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly RequestedExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly RequestedExpiryDate { get; init; } 
    #else
    public System.DateOnly RequestedExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the instructions from the bank.
    /// </summary>
    [IsoId("_-Dn20nltEeG7BsjMvd1mEw_1332855114")]
    [DisplayName("Bank Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkInstrs")]
    #endif
    [IsoXmlTag("BkInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BankInstructions1? BankInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankInstructions1? BankInstructions { get; init; } 
    #else
    public BankInstructions1? BankInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Contact at the issuing bank.
    /// </summary>
    [IsoId("_-Dn203ltEeG7BsjMvd1mEw_916958004")]
    [DisplayName("Bank Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkCtct")]
    #endif
    [IsoXmlTag("BkCtct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contacts3? BankContact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contacts3? BankContact { get; init; } 
    #else
    public Contacts3? BankContact { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the request.
    /// </summary>
    [IsoId("_-Dxn0HltEeG7BsjMvd1mEw_-1682717592")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the request.
    /// </summary>
    [IsoId("_-Dxn0XltEeG7BsjMvd1mEw_1306509943")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
