<?php
namespace App\Test\TestCase\Model\Table;

use App\Model\Table\FinalrankingTable;
use Cake\ORM\TableRegistry;
use Cake\TestSuite\TestCase;

/**
 * App\Model\Table\FinalrankingTable Test Case
 */
class FinalrankingTableTest extends TestCase
{
    /**
     * Test subject
     *
     * @var \App\Model\Table\FinalrankingTable
     */
    public $Finalranking;

    /**
     * Fixtures
     *
     * @var array
     */
    public $fixtures = [
        'app.Finalranking'
    ];

    /**
     * setUp method
     *
     * @return void
     */
    public function setUp()
    {
        parent::setUp();
        $config = TableRegistry::getTableLocator()->exists('Finalranking') ? [] : ['className' => FinalrankingTable::class];
        $this->Finalranking = TableRegistry::getTableLocator()->get('Finalranking', $config);
    }

    /**
     * tearDown method
     *
     * @return void
     */
    public function tearDown()
    {
        unset($this->Finalranking);

        parent::tearDown();
    }

    /**
     * Test initialize method
     *
     * @return void
     */
    public function testInitialize()
    {
        $this->markTestIncomplete('Not implemented yet.');
    }

    /**
     * Test validationDefault method
     *
     * @return void
     */
    public function testValidationDefault()
    {
        $this->markTestIncomplete('Not implemented yet.');
    }
}
