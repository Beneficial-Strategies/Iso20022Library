// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to statement frequency and form.
/// </summary>
[IsoId("_5U5pQA4rEeK3IMoVvcTkkg")]
[DisplayName("Statement Frequency And Form Modification")]
public partial record StatementFrequencyAndFormModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_CBMrAA4sEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 
    
    /// <summary>
    /// Specifies the statement frequency, format, delivery address.
    /// </summary>
    [IsoId("_H3PRUA4sEeK3IMoVvcTkkg")]
    [DisplayName("Statement Frequency And Form")]
    [IsoXmlTag("StmtFrqcyAndForm")]
    public required StatementFrequencyAndForm1 StatementFrequencyAndForm { get; init; } 
    
    
    #nullable disable
    
}
