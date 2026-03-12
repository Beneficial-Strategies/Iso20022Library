// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_amzfAVtiEeSwKe7KuKvXhg")]
[DisplayName("Individual Person")]
public partial record IndividualPerson26
{
    #nullable enable
    
    /// <summary>
    /// Name received at birth, for example, maiden name.
    /// </summary>
    [IsoId("_bDhQM1tiEeSwKe7KuKvXhg")]
    [DisplayName("Birth Name")]
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BirthName { get; init; } 
    
    /// <summary>
    /// First name of the person.
    /// </summary>
    [IsoId("_bDhQNVtiEeSwKe7KuKvXhg")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the person, for example, passport.
    /// </summary>
    [IsoId("_bDhQN1tiEeSwKe7KuKvXhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification6? Identification { get; init; } 
    
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_bDhQOVtiEeSwKe7KuKvXhg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LongPostalAddress2Choice_? Address { get; init; } 
    
    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_bDhQO1tiEeSwKe7KuKvXhg")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification40Choice_? EmployingParty { get; init; } 
    
    /// <summary>
    /// Specifies details related to the attendance card.
    /// </summary>
    [IsoId("_bDhQPVtiEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Card Details")]
    [IsoXmlTag("AttndncCardDtls")]
    public required AttendanceCard2 AttendanceCardDetails { get; init; } 
    
    
    #nullable disable
    
}
