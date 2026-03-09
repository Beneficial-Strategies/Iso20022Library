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
/// Confirmation information for the issued undertaking.
/// </summary>
[IsoId("_9yV5knltEeG7BsjMvd1mEw_-1807654359")]
[DisplayName("Undertaking Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingConfirmation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingConfirmation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingConfirmation1( PartyIdentification43 reqConfirmer,System.String reqReferenceNumber,DateAndDateTimeChoice_ reqDate )
    {
        Confirmer = reqConfirmer;
        ReferenceNumber = reqReferenceNumber;
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that adds its undertaking to honour the undertaking or amendment of the undertaking.
    /// </summary>
    [IsoId("_9yV5k3ltEeG7BsjMvd1mEw_-1094766461")]
    [DisplayName("Confirmer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnfrmr")]
    #endif
    [IsoXmlTag("Cnfrmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Confirmer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Confirmer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Confirmer { get; init; } 
    #else
    public PartyIdentification43 Confirmer { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_9yV5lHltEeG7BsjMvd1mEw_-1612716749")]
    [DisplayName("Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefNb")]
    #endif
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReferenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReferenceNumber { get; init; } 
    #else
    public System.String ReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the undertaking or amendment of the undertaking was confirmed.
    /// </summary>
    [IsoId("_9yV5lXltEeG7BsjMvd1mEw_-1478675936")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ Date { get; init; } 
    #else
    public DateAndDateTimeChoice_ Date { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of the undertaking or amendment of the confirmed undertaking.
    /// </summary>
    [IsoId("_9yV5lnltEeG7BsjMvd1mEw_-1395818404")]
    [DisplayName("Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Conf")]
    #endif
    [IsoXmlTag("Conf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Confirmation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
