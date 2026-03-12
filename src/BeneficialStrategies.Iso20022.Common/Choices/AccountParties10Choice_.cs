// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties10Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties10Choice.Trustee))]
    [KnownType(typeof(AccountParties10Choice.Nominee))]
    [KnownType(typeof(AccountParties10Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties10Choice.PrimaryOwner),nameof(AccountParties10Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties10Choice.Trustee),nameof(AccountParties10Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties10Choice.Nominee),nameof(AccountParties10Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties10Choice.JointOwner),nameof(AccountParties10Choice.JointOwner))]
    [IsoId("_wsxAU0NMEeamLdeYEZm56w")]
    [DisplayName("Account Parties 10 Choice")]
    public abstract partial record AccountParties10Choice_
    {
    }
}
