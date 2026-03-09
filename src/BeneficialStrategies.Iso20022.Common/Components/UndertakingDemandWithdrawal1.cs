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
/// Details of the demand withdrawal notification.
/// </summary>
[IsoId("_-Br9JnltEeG7BsjMvd1mEw_1678341433")]
[DisplayName("Undertaking Demand Withdrawal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingDemandWithdrawal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingDemandWithdrawal1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingDemandWithdrawal1( Undertaking6 reqUndertakingIdentification,Demand3 reqDemandDetails )
    {
        UndertakingIdentification = reqUndertakingIdentification;
        DemandDetails = reqDemandDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Br9J3ltEeG7BsjMvd1mEw_149297181")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking6 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking6 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking6 UndertakingIdentification { get; init; } 
    #else
    public Undertaking6 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-Br9KHltEeG7BsjMvd1mEw_-1462957369")]
    [DisplayName("Advising Party Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvsgPtyRefNb")]
    #endif
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdvisingPartyReferenceNumber { get; init; } 
    #else
    public System.String? AdvisingPartyReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-B1uIHltEeG7BsjMvd1mEw_-2032107044")]
    [DisplayName("Demand Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndDtls")]
    #endif
    [IsoXmlTag("DmndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Demand3 DemandDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Demand3 DemandDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Demand3 DemandDetails { get; init; } 
    #else
    public Demand3 DemandDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-B1uIXltEeG7BsjMvd1mEw_1834937574")]
    [DisplayName("Confirmer Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfrmrRefNb")]
    #endif
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmerReferenceNumber { get; init; } 
    #else
    public System.String? ConfirmerReferenceNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
