// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.PassportNumber),nameof(PersonIdentificationType1Choice.PassportNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.TaxIdentificationNumber),nameof(PersonIdentificationType1Choice.TaxIdentificationNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.SocialSecurityNumber),nameof(PersonIdentificationType1Choice.SocialSecurityNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.EmployerIdentificationNumber),nameof(PersonIdentificationType1Choice.EmployerIdentificationNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.DriversLicenseNumber),nameof(PersonIdentificationType1Choice.DriversLicenseNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.AlienRegistrationNumber),nameof(PersonIdentificationType1Choice.AlienRegistrationNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.IdentityCardNumber),nameof(PersonIdentificationType1Choice.IdentityCardNumber))]
    [JsonDerivedType(typeof(PersonIdentificationType1Choice.OtherIdentification),nameof(PersonIdentificationType1Choice.OtherIdentification))]
    #endif
    [IsoId("_QEW5kdp-Ed-ak6NoX_4Aeg_-1681666932")]
    [DisplayName("Person Identification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PersonIdentificationType1Choice_
    #else
    public abstract partial class PersonIdentificationType1Choice_
    #endif
    {
    }
}
