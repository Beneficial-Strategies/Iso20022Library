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
/// Status is rejected.
/// </summary>
[IsoId("_U23mVNp-Ed-ak6NoX_4Aeg_-2053158623")]
[DisplayName("Rejected Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status in the report.
    /// </summary>
    [IsoId("_U23mVdp-Ed-ak6NoX_4Aeg_96799303")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatusReason6> Reason { get; init; } = new ValueList<RejectedStatusReason6>(){};
    
    /// <summary>
    /// Proprietary identification of a reason for a rejected status in the report.
    /// </summary>
    [IsoId("_U23mVtp-Ed-ak6NoX_4Aeg_-2053158562")]
    [DisplayName("Data Source Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSrcSchme")]
    #endif
    [IsoXmlTag("DataSrcSchme")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<GenericIdentification1> DataSourceScheme { get; init; } = new ValueList<GenericIdentification1>(){};
    
    
    #nullable disable
    
}
