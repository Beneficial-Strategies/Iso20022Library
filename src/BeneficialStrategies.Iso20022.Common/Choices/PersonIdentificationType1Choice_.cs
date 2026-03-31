// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of personal identification type.
    /// </summary>
    [KnownType(typeof(PersonIdentificationType1Choice.PassportNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.SocialSecurityNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.EmployerIdentificationNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.DriversLicenseNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.AlienRegistrationNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.IdentityCardNumber))]
    [KnownType(typeof(PersonIdentificationType1Choice.OtherIdentification))]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.PassportNumber),
        nameof(PersonIdentificationType1Choice.PassportNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.TaxIdentificationNumber),
        nameof(PersonIdentificationType1Choice.TaxIdentificationNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.SocialSecurityNumber),
        nameof(PersonIdentificationType1Choice.SocialSecurityNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.EmployerIdentificationNumber),
        nameof(PersonIdentificationType1Choice.EmployerIdentificationNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.DriversLicenseNumber),
        nameof(PersonIdentificationType1Choice.DriversLicenseNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.AlienRegistrationNumber),
        nameof(PersonIdentificationType1Choice.AlienRegistrationNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.IdentityCardNumber),
        nameof(PersonIdentificationType1Choice.IdentityCardNumber)
    )]
    [JsonDerivedType(
        typeof(PersonIdentificationType1Choice.OtherIdentification),
        nameof(PersonIdentificationType1Choice.OtherIdentification)
    )]
    [IsoId("_QEW5kdp-Ed-ak6NoX_4Aeg_-1681666932")]
    [DisplayName("Person Identification Type 1 Choice")]
    public abstract record PersonIdentificationType1Choice_ { }
}
