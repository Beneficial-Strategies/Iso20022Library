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
/// Details of the intra-position movement.
/// </summary>
[IsoId("_ZcRuHZwxEeazcsnODTksnQ")]
[DisplayName("Intra Position Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionDetails44
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraPositionDetails44 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionDetails44( SecuritiesBalanceType8Choice_ reqBalanceFrom )
    {
        BalanceFrom = reqBalanceFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_ZcRuIZwxEeazcsnODTksnQ")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_ZcRuI5wxEeazcsnODTksnQ")]
    [DisplayName("Balance From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalFr")]
    #endif
    [IsoXmlTag("BalFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    #else
    public SecuritiesBalanceType8Choice_ BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [IsoId("_ZcRuJZwxEeazcsnODTksnQ")]
    [DisplayName("Intra Position Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraPosMvmnt")]
    #endif
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails14> IntraPositionMovement { get; init; } = new ValueList<IntraPositionMovementDetails14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ZcRuJZwxEeazcsnODTksnQ
    
    
    #nullable disable
    
}
