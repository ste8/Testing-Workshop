import unittest

class TestTestFramework(unittest.TestCase):

	def setUp(self):
		pass

	def test_framework(self):
		self.assertEqual(True, True)

if __name__ == '__main__':
	unittest.main()