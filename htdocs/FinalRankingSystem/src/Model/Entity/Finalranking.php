<?php
namespace App\Model\Entity;

use Cake\ORM\Entity;

/**
 * Finalranking Entity
 *
 * @property int $id
 * @property int $Score
 * @property \Cake\I18n\FrozenTime $Date
 */
class Finalranking extends Entity
{
    /**
     * Fields that can be mass assigned using newEntity() or patchEntity().
     *
     * Note that when '*' is set to true, this allows all unspecified fields to
     * be mass assigned. For security purposes, it is advised to set '*' to false
     * (or remove it), and explicitly make individual fields accessible as needed.
     *
     * @var array
     */
    protected $_accessible = [
        'Score' => true,
        'Date' => true
    ];
}
