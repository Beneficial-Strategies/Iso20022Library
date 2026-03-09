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
/// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_QE8vddp-Ed-ak6NoX_4Aeg_-1605328291")]
[DisplayName("Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionIdentification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a clearing system member, as assigned by the system or system administrator.
    /// </summary>
    [IsoId("_QE8vdtp-Ed-ak6NoX_4Aeg_1518346993")]
    [DisplayName("Clearing System Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSysMmbId")]
    #endif
    [IsoXmlTag("ClrSysMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; } 
    #else
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_QE8vd9p-Ed-ak6NoX_4Aeg_-256066049")]
    [DisplayName("Proprietary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryId")]
    #endif
    [IsoXmlTag("PrtryId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    #else
    public GenericIdentification4? ProprietaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QE8veNp-Ed-ak6NoX_4Aeg_1879167964")]
    [DisplayName("BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BIC")]
    #endif
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICIdentifier? BIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BIC { get; init; } 
    #else
    public System.String? BIC { get; set; } 
    #endif
    
    
    #nullable disable
    
}
