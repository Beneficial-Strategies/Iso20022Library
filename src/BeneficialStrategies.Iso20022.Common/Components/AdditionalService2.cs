// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services that have been or are to be performed in conjunction with the transaction.
/// </summary>
[IsoId("_KvaacZ1JEeublrfU-wN95w")]
[DisplayName("Additional Service")]
public partial record AdditionalService2
{
    #nullable enable
    
    /// <summary>
    /// Type of additional service applied to the transaction.
    /// </summary>
    [IsoId("_K04wUZ1JEeublrfU-wN95w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdditionalServiceType2Code Type { get; init; } 
    
    /// <summary>
    /// Other additional service applied to the transaction.
    /// </summary>
    [IsoId("_K05XYZ1JEeublrfU-wN95w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Result from performing the identified service.
    /// </summary>
    [IsoId("_eIwNsJ1JEeublrfU-wN95w")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public AdditionalServiceResult1Code? Result { get; init; } 
    
    /// <summary>
    /// Other nationally or privately defined additional service result code.
    /// </summary>
    [IsoId("_mYWP4J1KEeublrfU-wN95w")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherResult { get; init; } 
    
    /// <summary>
    /// Contains additional information for the execution or results of the service.
    /// </summary>
    [IsoId("_DODP4J1LEeublrfU-wN95w")]
    [DisplayName("Service Detail")]
    [IsoXmlTag("SvcDtl")]
    public AdditionalData1? ServiceDetail { get; init; } 
    
    
    #nullable disable
    
}
