// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>#13 across the model: every amount, wherever it is, carries the facets of the ISO amount type it stands for.</summary>
public class AmountFacetsInTheModelTests
{
    private static readonly Assembly Records = typeof(BeneficialStrategies.Iso20022.pacs.FIToFICustomerCreditTransferV14).Assembly;
    private static readonly Assembly Interfaces = typeof(IGenericIdentification3).Assembly;

    // The facets of the ISO amount types (total digits, fraction digits), as in the Primitives tests.
    private static readonly Dictionary<string, (int Total, int Fraction)> Expected = new()
    {
        ["ActiveCurrencyAnd13DecimalAmount"] = (18, 13),
        ["ActiveCurrencyAnd20Amount"] = (20, 19),
        ["ActiveCurrencyAnd24Amount"] = (24, 5),
        ["ActiveCurrencyAndAmount"] = (18, 5),
        ["ActiveOrHistoricCurrencyAnd13DecimalAmount"] = (18, 13),
        ["ActiveOrHistoricCurrencyAnd19DecimalAmount"] = (25, 19),
        ["ActiveOrHistoricCurrencyAnd20Amount"] = (20, 19),
        ["ActiveOrHistoricCurrencyAnd20DecimalAmount"] = (25, 20),
        ["ActiveOrHistoricCurrencyAndAmount"] = (18, 5),
        ["CurrencyAndAmount"] = (18, 5),
        ["RestrictedFINActiveCurrencyAnd13DecimalAmount"] = (14, 13),
        ["RestrictedFINActiveCurrencyAndAmount"] = (14, 5),
        ["RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount"] = (14, 13),
        ["RestrictedFINActiveOrHistoricCurrencyAndAmount"] = (14, 5),
    };

    // A choice variant that replicates an amount names the amount type in the display name of its Amount member.
    private static string AmountTypeNamedBy(PropertyInfo amount)
    {
        var displayName = amount.GetCustomAttribute<System.ComponentModel.DisplayNameAttribute>()!.DisplayName;
        return displayName.Replace(" _ Amount", "").Replace(" ", "");
    }

    private static IEnumerable<PropertyInfo> AmountMembers(IEnumerable<Type> types) =>
        types
            .SelectMany(t => t.GetProperties())
            .Where(p => p.Name == "Amount" && p.PropertyType == typeof(decimal) && p.GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag == "Amount");

    [Fact]
    public void EveryVariantThatReplicatesAnAmount_HasTheFacetsOfThatAmountType()
    {
        var members = AmountMembers(Records.GetTypes().Where(t => t.IsClass && t.Namespace?.StartsWith("BeneficialStrategies.Iso20022.Choices") == true)).ToList();
        var problems = new List<string>();
        foreach (var member in members)
        {
            var type = AmountTypeNamedBy(member);
            var facets = member.GetCustomAttribute<IsoAmountAttribute>();
            if (!Expected.TryGetValue(type, out var expected))
                problems.Add($"{member.DeclaringType!.FullName}: the amount type '{type}' is not in the table");
            else if (facets is null)
                problems.Add($"{member.DeclaringType!.FullName}: no [IsoAmount]");
            else if ((facets.TotalDigits, facets.FractionDigits) != expected)
                problems.Add($"{member.DeclaringType!.FullName}: ({facets.TotalDigits}, {facets.FractionDigits}) but {type} is {expected}");
        }

        Assert.True(members.Count >= 61, $"found only {members.Count} variants with an amount");
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }

    [Fact]
    public void TheInterfaceOfEachSuchVariant_CarriesTheSameFacets()
    {
        var problems = new List<string>();
        foreach (var member in AmountMembers(Records.GetTypes().Where(t => t.IsClass && t.Namespace?.StartsWith("BeneficialStrategies.Iso20022.Choices") == true)))
        {
            var record = member.DeclaringType!;
            var iface = Interfaces.GetType($"{record.Namespace}.I{record.Name}");
            var onInterface = iface?.GetProperty("Amount")?.GetCustomAttribute<IsoAmountAttribute>();
            var onRecord = member.GetCustomAttribute<IsoAmountAttribute>()!;
            if (onInterface is null || (onInterface.TotalDigits, onInterface.FractionDigits) != (onRecord.TotalDigits, onRecord.FractionDigits))
                problems.Add(record.FullName!);
        }

        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }

    [Fact]
    public void AnAmountOutsideTheFacets_InAWholeMessage_IsReportedWithItsPath()
    {
        var message = new BeneficialStrategies.Iso20022.pacs.MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "1",
            },
            SettlementRequest =
            [
                new MultilateralSettlementRequest3
                {
                    InstructionIdentification = "INSTR-001",
                    MovementRecord =
                    [
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new BeneficialStrategies.Iso20022.Amounts.ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m } },
                            Identification = "MOV-001",
                        },
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new BeneficialStrategies.Iso20022.Amounts.ActiveCurrencyAndAmount { Currency = "EUR", Amount = 200m } },
                            Identification = "MOV-002",
                        },
                    ],
                },
            ],
        };
        var xml = Iso20022XmlSerializer.SerializeToString(message).Replace(">100<", ">-1<").Replace(">200<", ">99999999999999999999999999<");

        var result = Iso20022XmlSerializer.TryRead<BeneficialStrategies.Iso20022.pacs.MultilateralSettlementRequestV02>(xml);

        Assert.False(result.Succeeded);
        Assert.Equal(2, result.Issues.Count);
        Assert.All(result.Issues, i => Assert.Equal(IssueCode.FacetViolation, i.Code));
        Assert.Contains("MvmntRcrd[1]", result.Issues[0].Path);
        Assert.Contains("MvmntRcrd[2]", result.Issues[1].Path);
    }
}
