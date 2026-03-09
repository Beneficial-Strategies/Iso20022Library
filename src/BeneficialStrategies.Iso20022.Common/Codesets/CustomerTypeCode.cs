// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nElNsFzCEeeDqe2giKl0eQ")]
[Description(@"Type of customer.")]
[Derivations(typeof(CustomerType2Code))]
public enum CustomerTypeCode
{
    /// <summary>
    /// Customer acting on his own as an individual.
    /// Encoded/decoded by serializers as &quot;INPE&quot;.
    /// </summary>
    [EnumMember(Value = "INPE")]
    [IsoId("_s5GxEFzCEeeDqe2giKl0eQ")]
    [Description(@"Customer acting on his own as an individual.")]
    IndividualPerson,
    
    /// <summary>
    /// Customer acting on behalf of a corporation  (e.g. in the framework of an employment contract).
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_5QSJIFzCEeeDqe2giKl0eQ")]
    [Description(@"Customer acting on behalf of a corporation  (e.g. in the framework of an employment contract).")]
    CorporateCustomer,
    
    /// <summary>
    /// Customer acting on behalf of a government or related entity.
    /// Encoded/decoded by serializers as &quot;GOVE&quot;.
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_Gz77YFzDEeeDqe2giKl0eQ")]
    [Description(@"Customer acting on behalf of a government or related entity.")]
    Government,
    
    /// <summary>
    /// Customer acting in the framework of a commercial contract with a third-party.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_cMyvUFzDEeeDqe2giKl0eQ")]
    [Description(@"Customer acting in the framework of a commercial contract with a third-party.")]
    Commercial,
    
    /// <summary>
    /// Other type of activity defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_szCv4FzDEeeDqe2giKl0eQ")]
    [Description(@"Other type of activity defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of activity defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_xRuhsFzDEeeDqe2giKl0eQ")]
    [Description(@"Other type of activity defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Customer acting as an individual in a group.
    /// Encoded/decoded by serializers as &quot;INGR&quot;.
    /// </summary>
    [EnumMember(Value = "INGR")]
    [IsoId("_sRkccHhMEee6_vnrijrKgg")]
    [Description(@"Customer acting as an individual in a group.")]
    IndividualInAGroup,
    
    /// <summary>
    /// Guest travelling in a business group on duty.
    /// Encoded/decoded by serializers as &quot;COGR&quot;.
    /// </summary>
    [EnumMember(Value = "COGR")]
    [IsoId("_TexZwHhjEeeDqfQQWUtugw")]
    [Description(@"Guest travelling in a business group on duty.")]
    CorporateGroup,
    
    /// <summary>
    /// Person engaged in a self employment contract.
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_w2opMHjzEeeiMfkH-CbtpQ")]
    [Description(@"Person engaged in a self employment contract.")]
    SelfEmployed,
    
    /// <summary>
    /// Company
    /// Encoded/decoded by serializers as &quot;CPNY&quot;.
    /// </summary>
    [EnumMember(Value = "CPNY")]
    [IsoId("_jSqEwC7QEemIy6A-26wnAg")]
    [Description(@"Company")]
    Company,
    
    /// <summary>
    /// Consumer
    /// Encoded/decoded by serializers as &quot;CSMR&quot;.
    /// </summary>
    [EnumMember(Value = "CSMR")]
    [IsoId("_jZAkYC7QEemIy6A-26wnAg")]
    [Description(@"Consumer")]
    Consumer,
    
}
