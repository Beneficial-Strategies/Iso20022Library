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
/// Details of the the status of a legally recognized subject or national of a particular country.
/// </summary>
[IsoId("_hRQnYQ2bEeSNWNtJlXOAhg")]
[DisplayName("Citizenship Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CitizenshipInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CitizenshipInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CitizenshipInformation1( string reqNationality )
    {
        Nationality = reqNationality;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    [IsoId("_nGXZkA2bEeSNWNtJlXOAhg")]
    [DisplayName("Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntlty")]
    #endif
    [IsoXmlTag("Ntlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NationalityCode Nationality { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Nationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Nationality { get; init; } 
    #else
    public string Nationality { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the person is a legal minor. It may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    [IsoId("_pxKL4A2bEeSNWNtJlXOAhg")]
    [DisplayName("Minor Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnrInd")]
    #endif
    [IsoXmlTag("MnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MinorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MinorIndicator { get; init; } 
    #else
    public System.String? MinorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the commencement of citizenship.
    /// </summary>
    [IsoId("_ssmpUA2bEeSNWNtJlXOAhg")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the end of citizenship.
    /// </summary>
    [IsoId("_vsqhAA2bEeSNWNtJlXOAhg")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
