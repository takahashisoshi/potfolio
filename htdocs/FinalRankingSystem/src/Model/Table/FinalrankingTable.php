<?php
namespace App\Model\Table;

use Cake\ORM\Query;
use Cake\ORM\RulesChecker;
use Cake\ORM\Table;
use Cake\Validation\Validator;

/**
 * Finalranking Model
 *
 * @method \App\Model\Entity\Finalranking get($primaryKey, $options = [])
 * @method \App\Model\Entity\Finalranking newEntity($data = null, array $options = [])
 * @method \App\Model\Entity\Finalranking[] newEntities(array $data, array $options = [])
 * @method \App\Model\Entity\Finalranking|bool save(\Cake\Datasource\EntityInterface $entity, $options = [])
 * @method \App\Model\Entity\Finalranking saveOrFail(\Cake\Datasource\EntityInterface $entity, $options = [])
 * @method \App\Model\Entity\Finalranking patchEntity(\Cake\Datasource\EntityInterface $entity, array $data, array $options = [])
 * @method \App\Model\Entity\Finalranking[] patchEntities($entities, array $data, array $options = [])
 * @method \App\Model\Entity\Finalranking findOrCreate($search, callable $callback = null, $options = [])
 */
class FinalrankingTable extends Table
{
    /**
     * Initialize method
     *
     * @param array $config The configuration for the Table.
     * @return void
     */
    public function initialize(array $config)
    {
        parent::initialize($config);

        $this->setTable('finalranking');
        $this->setDisplayField('id');
        $this->setPrimaryKey('id');
    }

    /**
     * Default validation rules.
     *
     * @param \Cake\Validation\Validator $validator Validator instance.
     * @return \Cake\Validation\Validator
     */
    public function validationDefault(Validator $validator)
    {
        $validator
            ->integer('id')
            ->allowEmptyString('id', 'create');

        $validator
            ->integer('Score')
            ->requirePresence('Score', 'create')
            ->allowEmptyString('Score', false);

        $validator
            ->dateTime('Date')
            ->allowEmptyDateTime('Date', false);

        return $validator;
    }
}
