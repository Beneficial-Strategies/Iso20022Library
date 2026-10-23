import unittest
import prepare_release as r


def issue(n, title, *labels, body="", reason="COMPLETED"):
    return {"number": n, "title": title, "labels": [{"name": l} for l in labels], "body": body, "stateReason": reason}


class Bump(unittest.TestCase):
    def test_highest_label_wins(self):
        e = r.build_entries([issue(1, "a", "bug"), issue(2, "b", "enhancement"), issue(3, "c", "documentation")], {})
        self.assertEqual("minor", r.choose_bump(e))
        e = r.build_entries([issue(1, "a", "bug"), issue(2, "b", "enhancement", "breaking-change")], {})
        self.assertEqual("major", r.choose_bump(e))

    def test_only_bugs_is_a_revision(self):
        self.assertEqual("revision", r.choose_bump(r.build_entries([issue(1, "a", "bug"), issue(2, "b", "documentation")], {})))

    def test_snapshot_sync_and_message_support_are_minor(self):
        self.assertEqual("minor", r.choose_bump(r.build_entries([issue(1, "a", "snapshot-sync")], {})))
        self.assertEqual("minor", r.choose_bump(r.build_entries([issue(1, "a", "message-support")], {})))

    def test_versions_keep_the_suffix(self):
        self.assertEqual("0.7.1-alpha", r.next_version("0.7.0-alpha", "revision"))
        self.assertEqual("0.8.0-alpha", r.next_version("0.7.3-alpha", "minor"))
        self.assertEqual("2.0.0", r.next_version("1.4.2", "major"))

    def test_leaving_zero_is_a_decision(self):
        with self.assertRaises(SystemExit):
            r.next_version("0.7.0-alpha", "major")
        self.assertEqual("1.0.0-alpha", r.next_version("0.7.0-alpha", "major", graduate=True))


class Entries(unittest.TestCase):
    def test_not_planned_and_no_release_notes_are_left_out(self):
        e = r.build_entries([issue(1, "a", "bug", reason="NOT_PLANNED"), issue(2, "b", "bug", "no-release-notes"), issue(3, "c", "bug")], {})
        self.assertEqual([3], [x["number"] for x in e])

    def test_release_note_line_beats_the_title(self):
        e = r.build_entries([issue(5, "Title", "bug", body="x\nRelease note: Fixed the thing.\n")], {})
        self.assertEqual("Fixed the thing.", e[0]["text"])
        e = r.build_entries([issue(5, "Title", "bug", body="Release note: from issue")], {5: ["Release note: from the PR"]})
        self.assertEqual("from the PR", e[0]["text"])

    def test_empty_release_note_placeholder_falls_back_to_the_title(self):
        e = r.build_entries([issue(5, "Title", "bug")], {5: ["Release note:\n"]})
        self.assertEqual("Title", e[0]["text"])

    def test_areas_route_to_packages_and_sagas_are_unpublished(self):
        e = r.build_entries([issue(1, "a", "bug", "area:validation"), issue(2, "b", "bug"), issue(3, "c", "bug", "area:sagas")], {})
        self.assertEqual({"validation"}, e[0]["packages"])
        self.assertEqual({"validation", "payloads", "xml", "samples"}, e[1]["packages"])
        self.assertEqual([1, 2], [x["number"] for x in e])


class Render(unittest.TestCase):
    def test_block_is_in_the_existing_style_and_ordered_by_heading(self):
        e = r.build_entries([issue(2, "Fix thing", "bug"), issue(1, "New message", "message-support"), issue(3, "Rename", "breaking-change")], {})
        block = r.render_block("0.8.0-alpha", e, "validation")
        self.assertEqual("0.8.0-alpha\n    Breaking change: Rename (#3).\n    Added: New message (#1).\n    Fixed: Fix thing (#2).\n", block)

    def test_append_keeps_the_blank_line_between_versions(self):
        self.assertEqual("0.1.0\n    a\n\n0.2.0\n    b\n", r.append_block("0.1.0\n    a\n", "0.2.0\n    b\n"))

    def test_version_is_replaced_in_the_props(self):
        self.assertEqual("<Version>0.8.0-alpha</Version>", r.set_version("<Version>0.7.0-alpha</Version>", "0.8.0-alpha"))


if __name__ == "__main__":
    unittest.main()
